﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToolsLibrary
{
    /// <summary>
    /// Абстрактный класс. Представляет инструмент для рисования.
    /// </summary>
    public abstract class DrawTool
    {
        private string _Color;

        /// <summary>
        /// Цвет, которым рисует инструмент.
        /// </summary>
        public string Color
        {
            get
            {
                if (_Color == "")
                    return "белый";
                else return this._Color;
            }
            set
            {
                try
                {
                    this._Color = value;
                }
                catch
                {
                    this._Color = "белый";
                }
            }
        }

        /// <summary>
        /// Абстрактный метод (реализация отсутствует). Представляет метод, позволяющий рисовать инструментом.
        /// </summary>
        /// <param name="ToolsOutputHandler">Контроллер вывода данных.</param>
        public abstract void Draw(OutputHandler ToolsOutputHandler);
    }
}
