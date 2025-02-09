# Vintage Symphony
This is a fork of the original Vintage Symphony, adding a few additional features and updating the mod to 1.20.x

## New Features
Music played on death ("Death Situation")

## Adding Music
(Haven't checked if Vintage Symphony Assets downloads)
Following your first install of Vintage Symphony, load a world once, then continue:
Find "vintage-symphony-assets_1.0.0.zip" in your mod folder.
Unzip it somewhere.
From here, you can add/remove tracks. Navigate to the folder with the music and musicconfig.json (located inside assets/vintage-symphony/music)
To Remove a track:
Remove the track's entry in musicconfig.json, and delete its .ogg file.
Alternatively, modify its musicconfig.json entry to Edit a track.
To Add a track:
Create a new entry in musicconfig.json. Copy/Paste one of the other entries and edit it:
- "$type": "leave this the same"
- "source": "you can put anything in here"
- "file": "The name of your file. It must: be lowercase and use dashes, and the file must be .ogg, and you do not include the file's extension here." <- Special characters don't tend to work well, stick to the alphabet. Additonally, THE MUSIC FILE MUST BE .OGG
- "title": "you can put anything in here"
- "onPlayList": "leave this the same"
- "situation": "idle|calm|adventure|danger|cave|temporalstorm" <- Note: You may need to play with priority to get a cave music track to play, and songs that play during temporalstorm will not sound right at all, due to the auditorial glitch affects from the temporal storm.
- "volume": 1 <- Whatever volume you desire. 1 tends to work most of the time.
- Extra Properties. No comprehensive lists, scroll through the default music entries to find examples of the various properties. One notable property is "priority", this can be useful to prioritize/deprioritize a track.

Once you are done adding/modifying/removing tracks, add the assets folder (with your modified music) and the modinfo.json to a zip archive, then replace the original zip file in your mods folder. Recommended to use the exact same name for your new zip.

If the game crashes, and the logs say something about vintage symphony, check if any songs in musicconfig.json don't have a file counterpart/the file counterpart is incorrectly named.
A non .ogg file will crash the game if it gets played.
Weird/non-standardized names (lowercase, dashes, no special characters) will tend to cause problems more often than not.
