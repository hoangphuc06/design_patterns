using CompositeDesignPattern;


// Create files (leaf object)
IComponent fileA = new MyFile("file A");
IComponent fileB = new MyFile("file B");
IComponent fileC = new MyFile("file C");

// Create folders (composite object)
Folder rootFolder = new ("Root Folder");
Folder folderB = new ("Folder B");
Folder folderC = new ("Folder C");

// Create explorer structure
// Add file A in root folder
rootFolder.AddComponent(fileA);

// Add folder B in root folder
rootFolder.AddComponent(folderB);

// Add file B and C in folder C
folderC.AddComponent(fileB);
folderC.AddComponent(fileC);

// Add folder C in root folder
rootFolder.AddComponent(folderC);

// Get children of root folder
rootFolder.GetComponents();

// Right click file A and rename
/*fileA.RightClick();
fileA.Rename("CompositeFile");

// Right click folder C and rename
folderC.RightClick();
folderC.Rename("CompositeDesignPatternFolder");

// Get children of root folder after rename
rootFolder.GetComponents();*/

// Delete all item
rootFolder.Delete();

//Get size of root folder
rootFolder.GetSize();
