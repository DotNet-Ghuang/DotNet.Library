using System;
using DotNet.Library.Logging;


namespace DotNet.Library.Json
{
    /// <summary>
    /// 统一的日志记录接口，用于解耦日志实现
    /// </summary>
    /// <remarks>
    /// 此接口的设计目的是提供一个统一的日志记录标准，
    /// 使得 JsonCore 等组件可以在不依赖具体日志实现的情况下工作。
    /// 通过依赖注入方式，可以灵活切换不同的日志实现。
    /// </remarks>
    public interface ILogger
    {
        /// <summary>
        /// 记录错误信息
        /// </summary>
        /// <param name="source">日志来源标识（通常是类名）</param>
        /// <param name="message">错误消息</param>
        void Error(string source, string message);

        /// <summary>
        /// 记录异常信息
        /// </summary>
        /// <param name="source">日志来源标识（通常是类名）</param>
        /// <param name="ex">异常对象</param>
        /// <param name="message">相关消息</param>
        void Exception(string source, Exception ex, string message);

        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="source">日志来源标识（通常是类名）</param>
        /// <param name="message">调试消息</param>
        void Debug(string source, string message);

        /// <summary>
        /// 记录一般信息
        /// </summary>
        /// <param name="source">日志来源标识（通常是类名）</param>
        /// <param name="message">信息内容</param>
        void Info(string source, string message);

        /// <summary>
        /// 记录警告信息
        /// </summary>
        /// <param name="source">日志来源标识（通常是类名）</param>
        /// <param name="message">警告消息</param>
        void Warning(string source, string message);
    }

    /// <summary>
    /// LogCore适配器实现ILogger接口
    /// </summary>
    public class LogCoreAdapter : ILogger
    {
        private readonly LogCore _logCore;

        /// <summary>
        /// 构造函数
        /// </summary>
        public LogCoreAdapter()
        {
            _logCore = new LogCore();
        }

        /// <summary>
        /// 记录错误信息
        /// </summary>
        public void Error(string source, string message)
        {
            _logCore.Error(source, message);
        }

        /// <summary>
        /// 记录异常信息
        /// </summary>
        public void Exception(string source, Exception ex, string message)
        {
            _logCore.Exception(source, ex, message);
        }

        /// <summary>
        /// 记录调试信息
        /// </summary>
        public void Debug(string source, string message)
        {
            _logCore.Debug(source, message);
        }

        /// <summary>
        /// 记录一般信息
        /// </summary>
        public void Info(string source, string message)
        {
            _logCore.Info(source, message);
        }

        /// <summary>
        /// 记录警告信息
        /// </summary>
        public void Warning(string source, string message)
        {
            _logCore.Warning(source, message);
        }
    }

    /// <summary>
    /// 使用LogHelper的日志适配器实现
    /// </summary>
    public class LogCoreAdapter2 : ILogger
    {
        /// <summary>
        /// 记录错误信息
        /// </summary>
        public void Error(string source, string message)
        {
            LogHelper.Error(source, message);
        }

        /// <summary>
        /// 记录异常信息
        /// </summary>
        public void Exception(string source, Exception ex, string message)
        {
            LogHelper.Exception(source, ex, message);
        }

        /// <summary>
        /// 记录调试信息
        /// </summary>
        public void Debug(string source, string message)
        {
            LogHelper.Debug(source, message);
        }

        /// <summary>
        /// 记录一般信息
        /// </summary>
        public void Info(string source, string message)
        {
            LogHelper.Info(source, message);
        }

        /// <summary>
        /// 记录警告信息
        /// </summary>
        public void Warning(string source, string message)
        {
            LogHelper.Warning(source, message);
        }
    }
}
