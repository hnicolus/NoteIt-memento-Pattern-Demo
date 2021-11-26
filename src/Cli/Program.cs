using NoteIt.Cli.Editor;
using static System.Console;

EditorViewModel viewModel = new();
string? textUserWillType = "Hello";


static void SimulateUserPause() => Thread.Sleep(500);

// simulator user interaction 
for (int x = 0; x < textUserWillType.Length; x++)
{
    SimulateUserPause();
    //add newly typed character to editor
    viewModel.Content = textUserWillType[..x];
    //display new content to screen
    WriteLine(viewModel.Content);
}


SimulateUserPause();
//Change Font Size  
viewModel.FontSize = 18;
WriteLine($"Font Size : {viewModel.FontSize}");
SimulateUserPause();
viewModel.FontSize = 35;
WriteLine($"Font Size : {viewModel.FontSize}");
//Undo two previous changes
viewModel.Undo();
SimulateUserPause();
WriteLine($"Font Size : {viewModel.FontSize}");
viewModel.Undo();
WriteLine($"Font Size : {viewModel.FontSize}");

//Change Font 
SimulateUserPause();
viewModel.FontFamily = "Lato";
WriteLine($"Font Family changed to {viewModel.FontFamily}");
//undo font change
viewModel.Undo();
WriteLine($"Font Family change undone, current font : {viewModel.FontFamily}");

//simulate Undo clicked 3 times
for (int i = 0; i < 3; i++)
{
    viewModel.Undo();
    WriteLine(viewModel.Content);
}
