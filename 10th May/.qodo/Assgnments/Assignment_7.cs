// Task 3: Method Overriding - Social Media Post

//Problem Statement:

//Simulate posting to different social media platforms by overriding the Post() method.

//Instructions:

using System;
using System.Collections.Generic;

class SocialMedia
{
    public virtual void Post()
    {
        Console.WriteLine("Posting on a social media Platform");
    }
}

class FacebookPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Facebook");
    }
}

class TwitterPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter");
    }
}

class InstagramPost : SocialMedia
{
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram");
    }
}

class Program
{
    static void Main()
    {
        // Using polymorphism
        List<SocialMedia> posts = new List<SocialMedia>
        {
            new FacebookPost(),
            new TwitterPost(),
            new InstagramPost()
        };

        foreach (SocialMedia post in posts)
        {
            post.Post(); // Will call the appropriate overridden method
        }
    }
}
