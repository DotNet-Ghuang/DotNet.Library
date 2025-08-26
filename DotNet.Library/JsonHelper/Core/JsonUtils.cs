using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DotNet.Library.Json
{
    /// <summary>
    /// JSON助手类，提供简化的JSON API
    /// </summary>
    public static class JsonUtils
    {
        private static readonly JsonCore _jsonCore = new JsonCore();

        #region 写入方法

        /// <summary>
        /// 写入对象到JSON文件
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="obj">要写入的对象</param>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>成功返回true，失败返回false</returns>
        public static bool WriteObject<T>(T obj, string filePath)
        {
            return _jsonCore.WriteObject(obj, filePath);
        }

        /// <summary>
        /// 写入数组到JSON文件
        /// </summary>
        /// <param name="array">要写入的数组</param>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>成功返回true，失败返回false</returns>
        public static bool WriteArray(string[] array, string filePath)
        {
            return _jsonCore.WriteArray(array, filePath);
        }

        /// <summary>
        /// 写入列表到JSON文件
        /// </summary>
        /// <typeparam name="T">列表元素类型</typeparam>
        /// <param name="list">要写入的列表</param>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>成功返回true，失败返回false</returns>
        public static bool WriteList<T>(List<T> list, string filePath)
        {
            return _jsonCore.WriteList(list, filePath);
        }

        /// <summary>
        /// 写入字典到JSON文件
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="dictionary">要写入的字典</param>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>成功返回true，失败返回false</returns>
        public static bool WriteDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, string filePath)
        {
            return _jsonCore.WriteDictionary(dictionary, filePath);
        }

        /// <summary>
        /// 写入DataTable到JSON文件
        /// </summary>
        /// <param name="dataTable">要写入的DataTable</param>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>成功返回true，失败返回false</returns>
        public static bool WriteDataTable(DataTable dataTable, string filePath)
        {
            return _jsonCore.WriteDataTable(dataTable, filePath);
        }

        /// <summary>
        /// 写入ArrayList到JSON文件
        /// </summary>
        /// <param name="arrayList">要写入的ArrayList</param>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>成功返回true，失败返回false</returns>
        public static bool WriteArrayList(ArrayList arrayList, string filePath)
        {
            return _jsonCore.WriteArrayList(arrayList, filePath);
        }

        /// <summary>
        /// 写入字符串到JSON文件
        /// </summary>
        /// <param name="value">要写入的字符串</param>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>成功返回true，失败返回false</returns>
        public static bool WriteString(string value, string filePath)
        {
            return _jsonCore.WriteString(value, filePath);
        }

        #endregion

        #region 读取方法

        /// <summary>
        /// 从JSON文件读取对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>读取的对象，失败返回默认值</returns>
        public static T ReadObject<T>(string filePath)
        {
            return _jsonCore.ReadObject<T>(filePath);
        }

        /// <summary>
        /// 从JSON文件读取数组
        /// </summary>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>读取的数组，失败返回null</returns>
        public static string[] ReadArray(string filePath)
        {
            return _jsonCore.ReadArray(filePath);
        }

        /// <summary>
        /// 从JSON文件读取列表
        /// </summary>
        /// <typeparam name="T">列表元素类型</typeparam>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>读取的列表，失败返回null</returns>
        public static List<T> ReadList<T>(string filePath)
        {
            return _jsonCore.ReadList<T>(filePath);
        }

        /// <summary>
        /// 从JSON文件读取字典
        /// </summary>
        /// <typeparam name="TKey">键类型</typeparam>
        /// <typeparam name="TValue">值类型</typeparam>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>读取的字典，失败返回null</returns>
        public static Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>(string filePath)
        {
            return _jsonCore.ReadDictionary<TKey, TValue>(filePath);
        }

        /// <summary>
        /// 从JSON文件读取DataTable
        /// </summary>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>读取的DataTable，失败返回null</returns>
        public static DataTable ReadDataTable(string filePath)
        {
            return _jsonCore.ReadDataTable(filePath);
        }

        /// <summary>
        /// 从JSON文件读取ArrayList
        /// </summary>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>读取的ArrayList，失败返回null</returns>
        public static ArrayList ReadArrayList(string filePath)
        {
            return _jsonCore.ReadArrayList(filePath);
        }

        /// <summary>
        /// 从JSON文件读取字符串
        /// </summary>
        /// <param name="filePath">可选的文件路径，不指定则使用初始化的路径</param>
        /// <returns>读取的字符串，失败返回null</returns>
        public static string ReadString(string filePath)
        {
            return _jsonCore.ReadString(filePath);
        }

        #endregion
    }
}