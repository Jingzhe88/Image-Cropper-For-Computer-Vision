﻿
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace FeatureStudio
{
    partial class ImageCropper
    {
        #region Multi-Mode Functions
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        //---------------------------以下代码匀为了在多核心CPU的系统上提高效率的代码----------------
        //---------------------------为了简洁，这代码均放在同一块区域中以方便阅读-------------------
        //---------------------------代码开始编写时间：2010年1月28日，黄纯得编写--------------------
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------

        //当有新的图片从外设返回时，可调用这方法来处理，与UpdateResutl功能相同，但在不同模式，以后需要改进
     

        // private void 
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        //---------------------------以下代码匀为了在多核心CPU的系统上提高效率的代码----------------
        //---------------------------为了简洁，这代码均放在同一块区域中以方便阅读-------------------
        //---------------------------代码开始编写时间：2010年1月28日，黄纯得编写--------------------
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------
        #endregion
      
        private void UpdateImageInvoker(Bitmap image)
        {
            if (image == null)
                return;
            if (backupImage != null)
                backupImage.Dispose();
            backupImage = (Bitmap)image.Clone();


        }

        #region video source region
     
        /// <summary>
        /// 关闭视频流
        /// </summary>
   

   

      
        #endregion
    }
}