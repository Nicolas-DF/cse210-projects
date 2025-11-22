using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // setting the videos
        Video video1 = new Video("How Stranger Things Should Have Ended (Season 1-4)", "HISHE", 304);
        Video video2 = new Video("OPTIMUS PRIME BR X USA", "@geral.podcuts", 60);
        Video video3 = new Video("IMPROBABLE | GOALS #16", "Barbixas", 644);

        // video1 comments
        video1.AddComment(new Comment("@soldlols", "Vecna wearing a cheer girl suite is absolutely the most cursed thing I ever watch"));
        video1.AddComment(new Comment("@TellItAnimated", "The bonus ending scene is on point haha"));
        video1.AddComment(new Comment("@TheDlamborn", "I like how HISHE also wants Eddie to be alive."));

        // video2 comments
        video2.AddComment(new Comment("@Pedro-dn8co", "His imitation looks like that scene with drunk Buzz Lightyear, lol."));
        video2.AddComment(new Comment("@maquinando307", "That's why the Brazilian dubbing is so exceptional, Optimus' voice is amazing."));
        video2.AddComment(new Comment("@rayssaceles351", "A voz do Briggs no Optimus trás um peso ainda maior pars o personagem. É surreal"));

        //video3 comments
        video3.AddComment(new Comment("@bunnymavi", "The best part of this game is the collective agony of everyone outside the scene combined with ours HAHAHAHA"));
        video3.AddComment(new Comment("@justarandomfella", "When Ballas said he was afraid of flying, I thought Elídio was going to say, 'Save the chickening for when you're on the plane.'"));
        video3.AddComment(new Comment("@spiderman100xd", "GOALS ARE BACK. WE WANT MORE, IT'S VERY GOOD."));

        List<Video> videos = new List<Video>{video1, video2, video3};
        
        foreach(var v in videos)
        {
            v.DisplayInfo();
        }
    }
}