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
        MediaPlayer.PositionChanged += (sender, args) =>
        {
            Console.WriteLine("The position is: "+args.Position);
        };
        MediaPlayer.LengthChanged += (sender, args) =>
        {
            Console.WriteLine("The length is: "+args.Length);
        };
    }
    
    public void Start()
    {
        using var media = new Media(_libVlc, new Uri("https://www040.vipanicdn.net/streamhls/739c46d1389c5e153dc6eadb1f097d6f/ep.1.1680395721.m3u8"));
        MediaPlayer.Play(media);
       
    }

}
