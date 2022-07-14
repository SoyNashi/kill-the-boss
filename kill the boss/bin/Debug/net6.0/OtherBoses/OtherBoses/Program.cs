Random rnd = new Random();
// float boss = rnd.Next(0, 10);
float boss = 0;
System.Diagnostics.Process pProcess = new System.Diagnostics.Process();


switch (boss)
{
    case 0:
        pProcess.StartInfo.FileName = "boss00.bat";
        // pProcess.StartInfo.Arguments = inputPath + " " + outputPath;
        pProcess.Start();
        // pProcess.WaitForExit();
        //pProcess.Close();
        break;
    /*
case 1:
    pProcess.StartInfo.FileName = "calc.exe";
    // pProcess.StartInfo.Arguments = inputPath + " " + outputPath;
    pProcess.Start();
    // pProcess.WaitForExit();
    //pProcess.Close();
    break;
    */
    /*
    default:
         pProcess.StartInfo.FileName = "calc.exe";
        // pProcess.StartInfo.Arguments = inputPath + " " + outputPath;
        pProcess.Start();
        // pProcess.WaitForExit();
        //pProcess.Close();
        break;
        */
}


/*
        System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
        pProcess.StartInfo.FileName = "calc.exe";
        // pProcess.StartInfo.Arguments = inputPath + " " + outputPath;
        pProcess.Start();
        pProcess.WaitForExit();
        pProcess.Close();
*/