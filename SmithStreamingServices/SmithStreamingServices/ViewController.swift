//
//  ViewController.swift
//  SmithStreamingServices
//
//  Created by Katie Smith on 11/13/22.
//

import UIKit

class ViewController: UIViewController {
    
    @IBOutlet weak var AppleToggle: UISwitch!
    @IBOutlet weak var AmazonToggle: UISwitch!
    @IBOutlet weak var PandoraToggle: UISwitch!
    @IBOutlet weak var SpotifyToggle: UISwitch!
    
    @IBOutlet weak var streamingLabel: UILabel!

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
        streamingLabel.text = "";
        AppleToggle.isOn = false;
        AmazonToggle.isOn = false;
        PandoraToggle.isOn = false;
        SpotifyToggle.isOn = false;
    }
    
    @IBAction func appleToggle(_ sender: Any) {
        if AppleToggle.isOn {
            let m = streamingLabel.text;
            streamingLabel.text = m! + " Apple";
        } else {
            if streamingLabel.text != nil {
                var str = streamingLabel.text
                str = str!.replacingOccurrences(of: "Apple", with: "")
                streamingLabel.text = str;
            }
        }
    }
    @IBAction func amazonToggle(_ sender: Any) {
        if AmazonToggle.isOn {
            let m = streamingLabel.text;
            streamingLabel.text = m! + " Amazon";
        } else {
            if streamingLabel.text != nil {
                var str = streamingLabel.text
                str = str!.replacingOccurrences(of: "Amazon", with: "")
                streamingLabel.text = str;
            }
        }
    }
    @IBAction func pandoraToggle(_ sender: Any) {
        if PandoraToggle.isOn {
            let m = streamingLabel.text;
            streamingLabel.text = m! + " Pandora";
        } else {
            if streamingLabel.text != nil {
                var str = streamingLabel.text
                str = str!.replacingOccurrences(of: "Pandora", with: "")
                streamingLabel.text = str;
            }
        }
    }
    @IBAction func spotifyToggle(_ sender: Any) {
        if SpotifyToggle.isOn {
            let m = streamingLabel.text;
            streamingLabel.text = m! + " Spotify";
        } else {
            if streamingLabel.text != nil {
                var str = streamingLabel.text
                str = str!.replacingOccurrences(of: "Spotify", with: "")
                streamingLabel.text = str;
            }
        }
    }
    
}

