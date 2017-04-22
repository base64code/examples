import base64

s = 'eW91ciB0ZXh0'.encode()
print(base64.b64decode(s).decode('utf-8'))

s = 'time for lunch'.encode()
print(base64.b64encode(s).decode('utf-8'))
