using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MoesApp.Models.Base
{
    /// <summary>
    /// Базовый класс модели
    /// </summary>
    internal abstract class ModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Изменение событий
        /// </summary>
        /// <param name="PropertyName">Свойство события</param>
        public virtual void OnPropertyChanged([CallerMemberName] string? PropertyName = null) // [CallerMemberName] - атрибут для компилятора, который подставляет имя метода из которого вызывается данная процедура
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        /// Метод обновления свойства для которого определено поле, в котором это свойство хранит свои данные
        /// </summary>
        /// <typeparam name="T">Тип свойства</typeparam>
        /// <param name="field">Поле свойства</param>
        /// <param name="value">Значение</param>
        /// <param name="PropertyName">Свойство события</param>
        /// <returns>Измененное свойство</returns>
        public virtual bool Set<T>(T field, T value, [CallerMemberName] string? PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
