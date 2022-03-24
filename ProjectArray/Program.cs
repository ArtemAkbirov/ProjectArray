using ProjectList;
using System;


ArrayList list = new ArrayList();

    list.AddIndex(0,1);
    list.Write();
    list.AddIndex(1, 9);
    list.Write();
    list.AddIndex(2, 3);
    list.Write();
    list.AddIndex(1, 5);
    list.Write();
    list.ChangeIndex(2, 2);
    list.Write();