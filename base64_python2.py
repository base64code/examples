import base64

s = 'SXQncyBsdW5jaCB0aW1l'
print base64.b64decode(s)

s = 'time for lunch'
print base64.b64encode(s)
