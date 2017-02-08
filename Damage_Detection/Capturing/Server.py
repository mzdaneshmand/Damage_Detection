import os
import time
import cPickle
import datetime
import logging
import flask
import werkzeug
import optparse
import tornado.wsgi
import tornado.httpserver
import numpy as np
import cStringIO as StringIO
import urllib
import base64
import socket
import os.path
try:
    os.remove('/home/pi/Desktop/captured.jpg')
except OSError:
    pass
try:
    os.remove('/home/pi/Desktop/video.h264')
except OSError:
    pass
s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
s.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
s.bind(('', 5000))
s.settimeout(.001)
app = flask.Flask(__name__)
cameraID = 0
@app.route('/capture', methods=['GET'])
def capture_get():
    while True:
        try:
            message, address = s.recvfrom(8192)
        except:
            break
    print message
    encoded_image = 0
    if 'captureVideo' in message:
        while not os.path.exists('/home/pi/Desktop/video.h264'):
            pass
        with open('/home/pi/Desktop/video.h264', 'rb') as image_file:
            encoded_image = base64.b64encode(image_file.read())
            os.remove('/home/pi/Desktop/video.h264')
    elif 'shoot' in message:
        while not os.path.exists('/home/pi/Desktop/captured.jpg'):
            pass
        with open('/home/pi/Desktop/captured.jpg', 'rb') as image_file:
            encoded_image = base64.b64encode(image_file.read())
            os.remove('/home/pi/Desktop/captured.jpg')
    return flask.jsonify(cameraid = cameraID,
                         image = encoded_image )
def start_tornado(app, port=5000):
    http_server = tornado.httpserver.HTTPServer(
        tornado.wsgi.WSGIContainer(app))
    http_server.listen(port)
    tornado.ioloop.IOLoop.instance().start()
def start_from_terminal(app):
    parser = optparse.OptionParser()
    parser.add_option(
        '-d', '--debug',
        help="enable debug mode",
        action="store_true", default=False)
    parser.add_option(
        '-p', '--port',
        help="which port to serve content on",
        type='int', default=9000)
    opts, args = parser.parse_args()
    if opts.debug:
        app.run(debug=True, host='0.0.0.0', port=opts.port)
    else:
        start_tornado(app, opts.port)
if __name__ == '__main__':
    logging.getLogger().setLevel(logging.INFO)
    start_from_terminal(app)
