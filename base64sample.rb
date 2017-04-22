require "base64"

s1 = 'SXQncyBsdW5jaCB0aW1l'
s_decoded = Base64.decode64(s1)
puts s_decoded

s2 = 'time for lunch'
s_encoded = Base64.encode64(s2)
puts s_encoded