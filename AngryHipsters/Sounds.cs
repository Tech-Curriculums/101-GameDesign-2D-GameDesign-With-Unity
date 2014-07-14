using System.Collections;

[RequireComponent(typeof(AudioSource))]
	public class Sounds : MonoBehaviour  {
		
	public AudioClip ScreechClip, stayGlassy;

	//stay glassy san francisco
		public void sayGlassy() {
			audio.clip = stayGlassy;
			audio.Play();
		}
		public void screech() {
			audio.clip = ScreechClip;
			audio.Play();
		}

}
