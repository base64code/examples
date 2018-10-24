package com.base64code.example;

import java.util.Base64;
// import org.apache.commons.codec.binary.Base64;

/**
 *
 * Base64 Example in Java
 */
public class Base64Sample {

    public static void main(String[] args) {
        /* Use this is for Java 8 */
        byte[] encodedBytes = Base64.getEncoder().encode("It's lunch time".getBytes());
        System.out.println("encodedBytes " + new String(encodedBytes));
        byte[] decodedBytes = Base64.getDecoder().decode(encodedBytes);
        System.out.println("decodedBytes " + new String(decodedBytes));
        
        /* And this, if using org.apache.commons.codec.binary.Base64 */
        byte[] encBytes = org.apache.commons.codec.binary.Base64.encodeBase64("It's lunch time".getBytes());
        System.out.println("encodedBytes " + new String(encBytes));
        byte[] decBytes = org.apache.commons.codec.binary.Base64.decodeBase64(encodedBytes);
        System.out.println("decodedBytes " + new String(decBytes));
    }
}