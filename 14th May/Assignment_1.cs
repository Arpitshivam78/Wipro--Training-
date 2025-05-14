/* 
Exercise 1: Interface - Music Player
💡 Problem Statement:
Create an interface to control music playback.
Instructions:
Create an interface IMusicPlayer with methods:
Play(string song)
Pause()
Stop()
Implement the interface in two classes:
SpotifyPlayer:
Prints "Playing [song] on Spotify"
Prints "Spotify playback paused"
Prints "Spotify playback stopped"
AppleMusicPlayer:
Prints "Playing [song] on Apple Music"
Prints "Apple Music playback paused"
Prints "Apple Music playback stopped"
In the Main() method:
Create objects of both classes using the IMusicPlayer reference.
Call all methods to demonstrate functionality. 
*/ 

using System;

using System.Collections.Generic;

using System.Linq;

class IMusicPlayer
{
    public void PLay(string song)
    {
        Console.WriteLine("Playing " + song + "on Apple Music");
    }

    public void Pause()
    {
        Console.WriteLine("Apple Music playback paused");
    }

    public void Stop()
    {
        Console.WriteLine("Apple Music playback stopped");
    }


}

class SpotifyPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine("Playing " + song + "on Spotify");
    }

    public void Pause()
    {
        Console.WriteLine("Spotify playback paused");
    }

    public void Stop()
    {
        Console.WriteLine("Spotify playback stopped");
    }
}

class AppleMusicPlayer : IMusicPlayer
{
    public void Play(string song)
    {
        Console.WriteLine("Playing " + song + "on Apple Music");
    }

    public void Pause()
    {
        Console.WriteLine("Apple Music playback paused");
    }

    public void Stop()
    {
        Console.WriteLine("Apple Music playback stopped");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMusicPlayer spotifyPlayer = new SpotifyPlayer();
        IMusicPlayer appleMusicPlayer = new AppleMusicPlayer();

        spotifyPlayer.PLay("Song 1");
        spotifyPlayer.Pause();
        spotifyPlayer.Stop();

        appleMusicPlayer.PLay("Song 2");
        appleMusicPlayer.Pause();
        appleMusicPlayer.Stop();
    }
}
