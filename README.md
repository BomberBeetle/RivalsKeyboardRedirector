# RivalsKeyboardRedirector
Redirects and splits keyboard input into multiple vJoy devices, enabling local play with two keyboards on Rivals of Aether. These are detected as GameCube Controllers by the game.

#How to Use
Firstly, enable however many vJoy devices you may need in the vJoy configuration, one for each keyboard. Keep in mind that GameCube controllers also consume vJoy devices. All of the vJoy devices need to have these features enabled, which by default always are. These are the X, Y, Z, Rx, Ry and Rz Axes and 32 buttons.
Then, press the 'Detect Keyboard' button and click any key on the desired keyboard. Set your keybinds and configurations, then enable the 'Enable vJoy Redirecting for this Keyboard' checkbox. Repeat the process for all other keyboards you want to use.
#Requirements:
You need to have vJoy installed, as well as an custom `custom_keyboard_controls.ini` supplied with this tool in your `%localappdata%\RivalsOfAether\saves\` folder

#Limitations
You cannot use this tool while simultaneously using the built-in keyboard controls. Those are disabled with the custom `custom_keyboard_controls.ini` file.
Certain tech that is performable with the built-in keyboard controls may behave differently. The only example found by the developer at the moment is easy cactuar dashes, performed by holding left or right simultaneosly with down on the built-in keyboard controls.
There is no support for mouse controls or double-tap dash at the moment.

#Planned Features
There is no permanent store of control schemes yet. The implementation of these are planned for later.
