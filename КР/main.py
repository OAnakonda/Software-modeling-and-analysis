class Convertor:
    def convert(number):
        try:
            res = 4046.8564224 * number
            return res
        except:
            return "Incorrect input"


class Main:
    def __init__(self):
        self.number = 1

    def set_number(self, number):
        self.number = int(number)

    def call_convert(self):
        self.result = Convertor.convert(self.number)

    def print(self):
        print(self.result)


if __name__ == '__main__':
    app = Main()
    print("Введіть квадратні метри що переведуться у акри\n")
    number = input("Квадратних метрів:\n\n> ")
    app.set_number(number)
    app.call_convert()
    app.print()
