import socket
import picamera
import os
s = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
s.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
s.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
s.bind(('', 5000))
s.settimeout(.001)
camera=picamera.PiCamera()
camera.video_stabilization=True
camera.resolution=(1920,1080)
camera.rotation=180
myFlag=0
while True:
    while True:
        try:
            message, address = s.recvfrom(8192)
            myFlag=1
        except:
            break
    if myFlag==1:
        myFlag=0
        print message
        if 'shoot' not in message:
            if 'captureVideo' in message:
                camera.start_recording('/home/pi/Desktop/video_1.h264')
                camera.wait_recording(10)
                camera.stop_recording()
                os.rename('/home/pi/Desktop/video_1.h264','/home/pi/Desktop/video.h264')
            elif 'clearData' in message:
                try:
                    os.remove('/home/pi/Desktop/video.h264')
                except OSError:
                    pass
                try:
                    os.remove('/home/pi/Desktop/captured.jpg')
                except OSError:
                    pass
            continue
        camera.capture('/home/pi/Desktop/captured_1.jpg')
        os.rename('/home/pi/Desktop/captured_1.jpg','/home/pi/Desktop/captured.jpg')
