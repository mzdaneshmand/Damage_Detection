#!bin/sh
sleep 5
#sudo python /home/pi/Desktop/multi_client.py 192.168.0.104 8888
sudo python /home/pi/Desktop/Server.py &
sudo python /home/pi/Desktop/CameraClient.py &