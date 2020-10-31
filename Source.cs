class SpeakerWake {

	static void Main() {

		System.Media.SoundPlayer Audio = new System.Media.SoundPlayer(@"C:\Program Files\SpeakerWake\noise.wav");
		while (true) {
			Audio.Play();
			System.Threading.Thread.Sleep(60000);
		}

	}

}