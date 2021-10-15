using UnityEngine;
using System.Collections;

public class AudioHelper : MonoBehaviour {

	public static AudioHelper Instance;



	public AudioClip titleAudio;
	public AudioClip subTitleAudio;

	public AudioClip titleAudioFemale;
	public AudioClip subTitleAudioFemale;


	public AudioClip answer1Audio;
	public AudioClip answer2Audio;
	public AudioClip answer3Audio;
	public AudioClip answer4Audio;


	public AudioClip answer1AudioFemale;
	public AudioClip answer2AudioFemale;
	public AudioClip answer3AudioFemale;
	public AudioClip answer4AudioFemale;



	public AudioSource audioSource;


	private string lastAudio = "";

	void Start()
	{


	}

	void Update(){


	}

	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;

		//audio = GetComponent<AudioSource>();

	}


	public void ActivateTitle()
	{
		MakeSound(titleAudio);
	}

	public void ActivateSubTitle()
	{
		MakeSound(subTitleAudio);
	}
		
	public void ActivateAnswer1Sound()
	{
		MakeSound(answer1Audio);
	}

	public void ActivateAnswer2Sound()
	{
		MakeSound(answer2Audio);
	}

	public void ActivateAnswer3Sound()
	{
		MakeSound(answer3Audio);
	}

	public void ActivateAnswer4Sound()
	{
		MakeSound(answer4Audio);
	}

	public void ActivateTitleFemale()
	{
		MakeSound(titleAudioFemale);
	}

	public void ActivateSubTitleFemale()
	{
		MakeSound(subTitleAudioFemale);
	}

	public void ActivateAnswer1SoundFemale()
	{
		MakeSound(answer1AudioFemale);
	}

	public void ActivateAnswer2SoundFemale()
	{
		MakeSound(answer2AudioFemale);
	}

	public void ActivateAnswer3SoundFemale()
	{
		MakeSound(answer3AudioFemale);
	}

	public void ActivateAnswer4SoundFemale()
	{
		MakeSound(answer4AudioFemale);
	}



	private void MakeFeelingSound(AudioClip originalClip)
	{

		if (lastAudio != originalClip.name) {

			if (originalClip != null) {

				if (!audioSource.isPlaying) {

					audioSource.clip = originalClip;
					audioSource.Play ();
					lastAudio = originalClip.name;


				} else if (originalClip.name != audioSource.clip.name) {

					audioSource.Stop ();
					audioSource.clip = originalClip;
					audioSource.Play ();

					lastAudio = originalClip.name;

				}

			}
		}
	}

	private void MakeSound(AudioClip originalClip)
	{

		// As it is not 3D audio clip, position doesn't matter.

		if (originalClip != null) {

			if (!audioSource.isPlaying) {

				audioSource.clip = originalClip;
				audioSource.Play ();

			} else if (originalClip.name != audioSource.clip.name) {

				audioSource.Stop ();
				audioSource.clip = originalClip;
				audioSource.Play ();
			}

		}
	}
}
