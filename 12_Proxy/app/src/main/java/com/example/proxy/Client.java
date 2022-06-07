package com.example.proxy;

import android.app.Activity;

public class Client
{
    public static void main(String[] args)
    {
        Internet internet = new ProxyInternet();
        try
        {
            internet.connectTo("cafedev.vn");
            internet.connectTo("abc.com");
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
        }
    }
}
