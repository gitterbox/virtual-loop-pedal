# Not maintained

[![No Maintenance Intended](http://unmaintained.tech/badge.svg)](http://unmaintained.tech/)

# Virtual Loop Pedal

Virtual Loop Pedal lets you record sounds and then plays them back in a loop. Each sound is recorded in a *Looper*. By Default you have 4 independent Loopers available, but you can add more.

The main benefit of this applications is that it allows you to align recordings to bars and phrases, which is really important in music. If each sound had a different length, they would not sound good together when repeating, because they would not line up. The synchronization is managed by *Metronome*.

## Metronome

Metronome is the main component of this application as it controls the synchronization of tracks (Loopers).

**Please note that the Metronome needs to be running if you want to record and play tracks in Loopers.**

*Measure* - this lets you set the number of beats in one bar. The first beat in each bar is emphasized (by a different sound).

*Tempo* - tempo lets you adjust the number of beats per minute. For example a tempo of 120 BPM means that every beat takes 0.5 seconds.

*Metronome offset* - you can set the offset (in milliseconds) of metronome beeps 

## Recorder

Recorder is a component unifies the Loopers. It records sound from your microphone (or other input) and then passes it to Loopers. You can also listen to the audio, which is being recorded at the time, by ticking the *Listen to recording* checkbox. This is useful when the recording device has only one output which is connected to the computer.

*Playback offset* - this lets you control the offset of sounds played from Loopers. You can use it to synchronize the recording with other tracks (as recording and playing back will have some latency).

## Looper

Looper is a unit that allows you to record sound and then play it back looped. Loopers are independent, so you can control each of them individually.

*Length of recording* - how long will the recording be (in bars). 

*Align on bars* - you often don't want to start recording immediately because you want to sync it with other tracks you have. This is exactly the option you need to use. Recording (or Playback) will start at the beginning of a bar, whose number is multiple of this value. So if you have other recordings which loop every 4 bars (have Length 4) and you want to align your next recording with them, you set this value to 4. It is recommended to set this to a multiple of Length. If you want to start recording immediately, set this to 0.

*Volume* - you can set volume of the playing track using the slider in the right part of the Looper.

### Recording 

1. Press the *Record* button. The indicator at the bottom of Looper will turn blue and it will show you how many beats are remaining before the recording starts (to be aligned). 
2. The recording will start at the beginning of a bar (unless you set *Align on bars* to 0). While recording, the indicator is red and shows you the remaining length of recording. 
3. To stop recording, press the *Stop* button.
4. The recording will also automatically stop after the number of bars you set in the *Length* option. (The automatic stop does not work when the metronome is not running)

**Please note that there will always be some latency between recording and playback. Setting Metronome offset to a negative value (recommended is same value as Playback latency, i.e. -100 for default settings)  or Playback offset might help you synchronize the recordings.**

### Playing 

Playing works similarly to recording. It also waits untill the start of aligned bar. Playback will automatically loop every *Length* bars (even if the recorded sound is shorter).

## Settings

In settings, you can control the input and output devices. You can also set the desired sample rate and latency.

*Sample Rate* - number of audio samples per second. Higher sample rate means higher CPU usage and bigger temporary files.

*Playback latency* - desired latency of the player in milliseconds. Setting this value below 100 may cause trouble.

*Buffer Size* - length of audio buffer in milliseconds. It's recommended to keep this on 100.

### Input and Output devices

* WaveEvent - standard driver for audio, should work on all platforms
* Wasapi - newer Windows audio driver, should be able to produce lower latency, but probably won't work with sample rate bellow 44,100 Hz.
  * Exclusive mode - Wasapi can work in Shared (default) or Exclusive mode, which should have lower latency, but blocks other apps from communicating with soundcard (so no other app will be able to play any audio).
* *ASIO* - *not implemented yet, might come in the future*

For each driver, you can select the input and output device you want. 

## Troubleshooting

Please note that the input sound from your microphone may be modified by Windows or other application. If you don't hear it well, try opening the sound settings in Windows and disable addons and modifiers.

## Keyboard Shortcuts
|Action	|Shortcut 1|Shortcut 2|
|-------|----------|----------|
|Start/Stop Metronome|Space|
|Stop Metronome|X||
|Enable/Disable Metronome Sound|M|
|Start/Stop Recording|N|R|
|Start/Stop Playback|B|P|
|Select Looper 1|F||
|Select Looper 2|G||
|Select Looper 3|H||
|Select Looper 4|J||
|Select Next Looper|V||
|Select Previous Looper|C|| 
