﻿namespace StreamStorage
{
    /// <summary>
    /// Runtime Environment
    /// </summary>
	public class RuntimeEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetPhysicalApplicationPath()
        {
            string path = "";
            if (System.Web.HttpContext.Current != null)
            {
                path = System.Web.HttpContext.Current.Request.PhysicalApplicationPath.TrimEnd(System.IO.Path.DirectorySeparatorChar);
            }
            else
            {
                path = System.AppDomain.CurrentDomain.BaseDirectory.TrimEnd(System.IO.Path.DirectorySeparatorChar);
            }
            return path;
        }
    }
}
