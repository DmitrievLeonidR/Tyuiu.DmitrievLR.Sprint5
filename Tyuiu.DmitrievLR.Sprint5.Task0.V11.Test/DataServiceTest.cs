﻿namespace Tyuiu.DmitrievLR.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "D:\\C_SPRINTS\\repos\\Tyuiu.DmitrievLR.Sprint5\\Tyuiu.DmitrievLR.Sprint5.Task0.V11\\bin\\Debug\\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            

            Assert.AreEqual(wait, fileExist);
        }
    } 