Template for games in Unity2D.

Music Manager:
See musicDemo scene for a working example. 
Move the Player to each of the colored zones to change the music dynamically.
To set up Music Manager from scratch:
	- Create a Music Manager GameObject and attach a musicManagerScript to it
	- Create two Audio Sources and set them as children of the Music Manager
	- Link the audioSourceScript to both Audio Sources
	- In the Music Manager inspector, link the two audio sources to the musicManagerScript Source 1 and Source 2 public variables
	- In the Music Manager inspector, link the appropriate audio clips in the desired Track 1, Track 2, and Track 3 public variables
	- Create a Player GameObject, include the following components: Box Collider, Rigidbody (uncheck use gravity from Rigidbody)
	- Link the musicManagerDemo_PlayerScript to the Player GameObject
	- Create a GameManager GameObject
	- Link the musicManagerDemp_GameManagerScript to the GameManager GameObject
	- Link the Music Manager and the Player GameObjects to their appropriate public variables in the GameManager's MusicManagerDemo_GameManagerScript
	- Create Three GameObjects named Zone1 Zone2 and Zone3, adding a Box Collider component to each and checking each as a IsTrigger
	- Finally set each of the three Zones's tags to "zone1" "zone2" and "zone3" appropratately


