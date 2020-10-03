#kodas skiriasi nuo C++ uzduoties, kadangi C++ uzduoti ne as dariau (nes as neturiu jokiu senu uzduociu ir ju realizaciju)
#esme ta pati, skaiciuoja taip pat, del idomumo neperkopijavau kodo, o parasiau savo salygas
STDOUT.sync = true
class Calculator
  def initialize(amount)#konstruktorius
    @amount = amount.to_f #priskiriu reiksme objektui
  end
  
    def CalculatePrice() #metodas skaiciuojantis kaina: kilovatai * kaina (kaina priklauso nuo kiekio, intervalais)
      price=0
      #atskiri ifai, nes logika pagal eiles tvarka (po kiekvieno IF mazeja kw skaicius)
      if(@amount>250)#jei kiekis didesnis nei 250
        price=price+(@amount-250)*1.5 #kaina = viskas kas virs 250 * 1.5
        @amount=@amount-(@amount-250) #is kilovatu sumos atima kilovatus, kuriuos padaugino(kurie buvo naudojami skaiciavime)
      end
      if(@amount<=250&&@amount>150)#ta pati logika kaip ir pirmoje salygoje
        price=price+(@amount-150)*1.2
        @amount=@amount-(@amount-150)
      end
      if(@amount<=150&&@amount>50)
        price=price+(@amount-50)*0.75
        @amount=@amount-(@amount-50)
      end
      if(@amount<=50)#likes kilovatu likutis dauginamas
        price=price+@amount*0.5
        @amount=@amount-@amount-50
      end
      return price #grazina kaina
    end
end

puts "Iveskite KW skaiciu:"
kw=gets  #read from console
calc=Calculator.new(kw) #sukuriamas objektas ir paduodama reiksme i konstruktoriu
puts "Moketi: #{calc.CalculatePrice}" #spausdinamas rezultatas