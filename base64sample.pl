use MIME::Base64;
use feature 'say';

$encoded = 'SXQncyBsdW5jaCB0aW1l';
$decoded = decode_base64($encoded);
say $decoded;

$string = 'time for lunch';
$encoded = encode_base64($string);
say $encoded
