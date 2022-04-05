using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MoesApp.ViewModels.Base
{
    /// <summary>
    /// Базовый класс модели-представления
    /// </summary>
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Событие
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Изменение событий
        /// </summary>
        /// <param name="PropertyName">Свойство события</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? PropertyName = null) // [CallerMemberName] - атрибут для компилятора, который подставляет имя метода из которого вызывается данная процедура
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        /// Метод обновления свойства для которого определено поле, в котором это свойство хранит свои данные
        /// </summary>
        /// <typeparam name="T">Тип свойства</typeparam>
        /// <param name="field">Ссылка на поле свойства</param>
        /// <param name="value">Значение</param>
        /// <param name="PropertyName">Свойство события</param>
        /// <returns>Измененное свойство</returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string? PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }
    }
}
