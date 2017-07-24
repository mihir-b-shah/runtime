﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLEDB.Test.ModuleCore;
using XmlCoreTest.Common;
using Xunit;

namespace System.Xml.Tests
{
    public class TCDefaultWriterSettings
    {
        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_1(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Compare(wSettings.Encoding, Encoding.UTF8, "Incorrect default value of Encoding");

            XmlWriter w = utils.CreateWriter();
            switch (utils.WriterType)
            {
                case WriterType.UTF8Writer:
                case WriterType.UTF8WriterIndent:
                case WriterType.CharCheckingWriter:
                case WriterType.WrappedWriter:
                    CError.Compare(w.Settings.Encoding.WebName, "utf-8", "Incorrect default value of Encoding");
                    break;
                case WriterType.UnicodeWriter:
                case WriterType.UnicodeWriterIndent:
                    CError.Compare(w.Settings.Encoding.WebName, "utf-16", "Incorrect default value of Encoding");
                    break;
            }
            w.Dispose();
            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_2(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Compare(wSettings.OmitXmlDeclaration, false, "Incorrect default value of OmitXmlDeclaration");

            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_3(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Compare(wSettings.NewLineHandling, NewLineHandling.Replace, "Incorrect default value of NewLineHandling");

            XmlWriter w = utils.CreateWriter();
            switch (utils.WriterType)
            {
                case WriterType.UTF8Writer:
                case WriterType.UnicodeWriter:
                    CError.Compare(w.Settings.NewLineHandling, NewLineHandling.Replace, "Incorrect default value of NewLineHandling");
                    break;
            }
            w.Dispose();
            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_4(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Equals(wSettings.NewLineChars, Environment.NewLine, "Incorrect default value of NewLineChars");

            XmlWriter w = utils.CreateWriter();
            CError.Equals(w.Settings.NewLineChars, Environment.NewLine, "Incorrect default value of NewLineChars");

            w.Dispose();
            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_5(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Equals(wSettings.Indent, false, "Incorrect default value of wSettings.Indent");

            XmlWriter w = utils.CreateWriter();
            CError.Equals(w.Settings.Indent, utils.IsIndent(), "Incorrect default value of w.Settings.Indent");
            w.Dispose();
            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_6(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Equals(wSettings.IndentChars, "  ", "Incorrect default value of IndentChars");

            XmlWriter w = utils.CreateWriter();
            CError.Equals(w.Settings.IndentChars, "  ", "Incorrect default value of IndentChars");

            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_7(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Equals(wSettings.NewLineOnAttributes, false, "Incorrect default value of NewLineOnAttributes");

            XmlWriter w = utils.CreateWriter();
            CError.Equals(w.Settings.NewLineOnAttributes, false, "Incorrect default value of NewLineOnAttributes");

            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_8(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Compare(wSettings.CloseOutput, false, "Incorrect default value of CloseOutput");

            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_10(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Equals(wSettings.CheckCharacters, true, "Incorrect default value of CheckCharacters");

            XmlWriter w = utils.CreateWriter();
            CError.Equals(w.Settings.CheckCharacters, true, "Incorrect default value of CheckCharacters");

            w.Dispose();
            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_11(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings wSettings = new XmlWriterSettings();
            CError.Equals(wSettings.ConformanceLevel, ConformanceLevel.Document, "Incorrect default value of ConformanceLevel");

            XmlWriter w = utils.CreateWriter();
            CError.Equals(w.Settings.ConformanceLevel, ConformanceLevel.Document, "Incorrect default value of ConformanceLevel");

            w.Dispose();
            return;
        }

        [Theory]
        [XmlWriterInlineData(TestCaseUtilsImplementation.XmlFactoryWriter, WriterType.AllButCustom)]
        public void default_13(XmlWriterTestCaseBase utils)
        {
            XmlWriterSettings ws = new XmlWriterSettings();
            CError.Equals(ws.WriteEndDocumentOnClose, true, "Incorrect default value of WriteEndDocumentOnClose");

            XmlWriter w = utils.CreateWriter();
            CError.Equals(w.Settings.WriteEndDocumentOnClose, true, "Incorrect default value of WriteEndDocumentOnClose");

            w.Dispose();

            return;
        }
    }

}
