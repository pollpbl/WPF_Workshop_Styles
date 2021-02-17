﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFDesignStyles.BusinessLogic.Models.Dialogs;

namespace WPFDesignStyles.BusinessLogic.Services.Dialogs
{
    public interface IDialogService
    {
        OpenDialogResult ShowOpenDialog(string filter = null, string title = null, string filename = null);
        SaveDialogResult ShowSaveDialog(string filter = null, string title = null, string filename = null);
    }
}
