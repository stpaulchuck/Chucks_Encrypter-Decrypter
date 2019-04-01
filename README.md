# Chuck's Encrypter/Decrypter

![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](http://www.repostatus.org/badges/latest/inactive.svg)
[![lifecycle](https://img.shields.io/badge/lifecycle-stable-green.svg)](https://www.tidyverse.org/lifecycle/#stable)

## Description

I wrote an app for my Ham Radio operations to monitor a digital mode app to see if some new country showed up and then alert me. One of the optional alert modes is email. After I built the alerter application I noticed that all the email logon info was in plain text in the Properties Settings which left me vulnerable to hackers capturing my email credentials so I wrote this little encrypter/decrypter application to make it a lot harder to hack my email credentials. 

It is a very simple application. You can enter text to encrypt and push the button and see the encrypted results which I would then paste into the alerter application Settings page.

On the other direction you can enter some encrypted text and push another button and decrypt it and see the results.

There are two strings required to to this task - the Key string and the VI string. Read up on encryption in C# for more information. I won't burn a lot of bits on it here. What I will say is that the strings are coded into the WSJT-X application and when you start this app those strings will be loaded. If you wish to personalize either or both you need to bring up Visual Studio 2017, load the source code and edit these strings and ensure they match between the two apps and recompile both. This way you can change your email setting values quickly and painlessly.

## The Project

I wrote this a couple years ago so I updated it just now with .Net 4.7.2 and I wired in the Key and VI strings to show up on form load. You can still enter any other Key and VI string for other encoding purposes after startup. (don't forget to write them down!!)

For some quick info on these strings look at the source code for the main form, even just with a plain text editor like Notepad. I've made some comments on the length of the strings you should be aware of.

Here's a copy:

```csharp
  // legal sizes for AES Key = (128 to 256)/block size(currently 8), so 24*8=192
  // legal sizes for AES IV = 128/block size(currently 8), so 16*8=128
  // legal sizes for key in TripleDES is 128-192, IV seems to be mulitples of 8
```

## License

This software is licensed under the GNU General Public License Version 3 (and newer if published).
