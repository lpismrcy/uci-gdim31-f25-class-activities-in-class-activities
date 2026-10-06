# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.
When I run the game everything initially looks correct, but as soon as you start moving the cat everything goes wrong. You see the cat moving yet the camera remains in a fixed position. The controls for the cat still work one hindred percent correctly, but the camera is now in a fixed location.
https://lapismercy.itch.io/mcgilljweek1cat
### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
1. The r g b variables can not be booleans as they must have a numerical value, true and false won't cut it. Strings would not work as they can not properly chnage the variables in the way we want. We are using RGB on a scale from 0 to 1 so we need to use decimals, which integers won't allow. This only leaves floats as the viable option.
2. It makes the most sense for the _bounce variable to be a integer as we only ever need it to go up by one. Using a string would not numerically add, instead it would just stick on another number in the end. True or false does not apply so booleans are out of the question. We do not need decimals so there is no reason to use floats, leaving integers as the obvious answer.
3. In C# you always need to end every line with a semicolon for the computer to properly read it. 
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 