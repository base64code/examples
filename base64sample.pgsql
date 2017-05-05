- Decoding
SELECT CONVERT_FROM(DECODE('SXQncyBsdW5jaCB0aW1l', 'BASE64'), 'UTF-8');

-- Encoding
SELECT ENCODE(CONVERT_TO('It''s lunch time', 'UTF-8'), 'BASE64');