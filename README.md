# AutoClicker

A small C# Winforms project using InputSimulator library to do the clicking and a Global KB hook to capture the F7 key to start/stop the clicking.
The UI:
- You can specify the delay between clicks in milliseconds. NOTE: This is woefully inaccurate due to a call to Application.DoEvents so that the UI stays responsive and the stats are updated.
- You can test it by hovering over the 'Test' button: the colors should rotate in the panel below.
- Closing the application should cancel the KB hook.

# Use at your own risk!
