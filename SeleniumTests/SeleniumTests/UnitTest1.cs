using System;
using NUnit.Framework;

namespace SeleniumTests
{
    [TestFixture]
    public class Tests : BrouserFunction
    {
        //Ввод неверного номер телефона
        //Шаги
        //Зайти на сайт
        //Перейти налюбое авто
        //Ввести в поле 'Ваше имя' Vadim
        //Ввести в поле 'Номер телефона' -3751111111
        //Ввести в поле 'Email' test@mail.ru
        //Нажать кнопку 'Забронировать'
        //Ожидаемый результат: Появление сообщения "Ваше сообщение отправлено!"
        [Test]
        public void OrderWithInvalidPhone()
        {               
            var OrderButton = GetWebElementByXPath("//button[@class='button submit-button']");
            OrderButton.Click();
            var CompliteOrder = GetWebElementByXPath("//div[@class='final-success']");
            Assert.AreEqual(CompliteOrder.Text, "check\r\nВаше сообщение отправлено!");
        }

        //Ввод неверной даты
        //Шаги
        //Зайти на сайт
        //Перейти налюбое авто
        //Ввести в поле 'Ваше имя' Vadim
        //Ввести в поле 'Номер телефона' -3751111111
        //Ввести в поле 'Email' test@mail.ru
        //Ввести в поле 'Начало аренды' 10/09/1999
        //Ввести в поле 'Окончание аренды' 23/10/2019
        //Нажать кнопку 'Забронировать'
        //Ожидаемый результат: Появление сообщения "Ваше сообщение отправлено!"
        [Test]
        public void OrderWithPastDate()
        {
            var StartRent = GetWebElementByName("field1");
            var EndRent = GetWebElementByName("field2");
            StartRent.SendKeys("10/09/1999");
            EndRent.SendKeys("23/10/2019");
            var OrderButton = GetWebElementByXPath("//button[@class='button submit-button']");
            OrderButton.Click();            
            //var CompliteOrder = GetWebElementByXPath("//div[@class='final-success']");
            var CompliteOrder = GetWebElementByXPath("//div[@class='final-success']");
            Assert.AreEqual(CompliteOrder.Text, "check");
        }
    }
}
