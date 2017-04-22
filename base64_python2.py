import base64

s = 'eW91ciB0ZXh0'
print base64.b64decode(s)

s = 'time for lunch'
print base64.b64encode(s)
