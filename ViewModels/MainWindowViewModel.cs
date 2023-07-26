using System;
using LibVLCSharp.Shared;

namespace Anion.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly LibVLC _libVlc = new ();
    public MediaPlayer MediaPlayer { get; }
    public MainWindowViewModel()
    {
        MediaPlayer = new MediaPlayer(_libVlc);
    }

    public string Greeting => "Welcome to Avalonia!";
    
    public void Play()
    {
        using var media = new Media(_libVlc, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
        MediaPlayer.Play(media);
    }

}
