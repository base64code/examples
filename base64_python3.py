import base64

s = 'SXQncyBsdW5jaCB0aW1l'.encode()
print(base64.b64decode(s).decode('utf-8'))

s = 'time for lunch'.encode()
print(base64.b64encode(s).decode('utf-8'))
