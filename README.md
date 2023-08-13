# NativeDllTester

This is a small tool to get the error code returned by `LoadLibrary` when it fails to load a library.

1. Place the executable in your Half-Life directory
2. Launch the program
3. Enter the path to the dll or click Browse to select it, then click Load
4. If an error occurs, the `Error Code` field contains the native error code.
The translated error message is displayed in the field below

Error messages are translated by C#'s `Win32Exception` class, so it can't be displayed in English.

See the [List of Error Codes](https://docs.microsoft.com/en-us/windows/desktop/debug/system-error-codes) to find the corresponding name and description in English.
