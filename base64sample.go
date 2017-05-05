package example

import (
	"encoding/base64"
	"fmt"
)

func main() {
	data := "YmFzZTY0IGVuY29kZWQgc3RyaW5n"
	sDec := base64.StdEncoding.DecodeString(data)
	fmt.Println(sDec)

	data := "base64 encoded string"
	sEnc := base64.StdEncoding.EncodeToString([]byte(data))
	fmt.Println(sEnc)
}