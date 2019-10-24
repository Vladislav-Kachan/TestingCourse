using System;
using NUnit.Framework;
using OpenQA.Selenium;

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
            var ImageCar = GetWebElementByXPath("//div[@class='elementor-element elementor-element-693b434 elementor-widget elementor-widget-image']");
            ImageCar.Click();
            var NameField = GetWebElementByName("field7[]");
            var PhoneField = GetWebElementByName("field9[]");
            var MailField = GetWebElementByName("field8");
            NameField.SendKeys("Vadim");
            PhoneField.SendKeys("-3751111111");
            MailField.SendKeys("test@mail.ru");
            var OrderButton = GetWebElementByXPath("//button[@class='button submit-button']");
            OrderButton.Click();
            var CompliteOrder = GetWebElementByXPath("//div[@class='final-success']");
            Assert.AreEqual(CompliteOrder.Text, "check\r\nВаше сообщение отправлено!");
        }

        //Ввод неверной даты
        //Шаги
        //Зайти на сайт
        //В поле "Марка или модель" ввести Lada
        //Нажать поиск        
        //Ожидаемый результат: В списке появяться машины модели Lada
        [Test]
        public void OrderWithPastDate()
        {
            var SearchMarka = GetWebElementByName("phrase");
            SearchMarka.SendKeys("Lada"+Keys.Enter);
            var NameCar = GetWebElementByXPath("//h2[@class='entry-title']");            
            Assert.IsTrue(NameCar.Text.StartsWith("Lada"));            
        }
    }
}
