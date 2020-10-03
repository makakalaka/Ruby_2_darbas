class Person
	attr_accessor :gender,:height,:weight
  def initialize(gender,height,weight)#konstruktorius
    @gender = gender.to_i #priskiriu reiksmes objektui
    @height = height.to_f 
    @weight = weight.to_f 
end
end

def Euclidean(people)#metodas, ieskantis ugio
	targetIndex=-1
	ratioIndex=-1
	ratio=99999
	for index in (0...people.length)
		if(people[index].height==0)
			targerIndex=index
		end
	end
	for index in (0...people.length)
		if (people[index].gender == people[targerIndex].gender&& index!=targerIndex)
			tempRatio = Math.sqrt((people[index].weight - people[targerIndex].weight)**2)
			if(tempRatio<ratio)
				ratio=tempRatio
				ratioIndex=index
			end
		end
	end
	puts"Euclidean-Atitikmuo:  #{index} asmuo, ugis:#{people[ratioIndex].height}"
end
def Manhattan(people)
	targetIndex=-1
	ratioIndex=-1
	ratio=99999
	for index in (0...people.length)
		if(people[index].height==0)
			targerIndex=index
		end
	end
	for index in (0...people.length)
		if (people[index].gender == people[targerIndex].gender&& index!=targerIndex)
			tempRatio = (people[index].weight - people[targerIndex].weight).abs
			if(tempRatio<ratio)
				ratio=tempRatio
				ratioIndex=index
			end
		end
	end
	puts"Manhattan-Atitikmuo:  #{index} asmuo, ugis:#{people[ratioIndex].height}"
end
def Maximum(people)
	targetIndex=-1
	ratioIndex=-1
	ratio=99999
	for index in (0...people.length)
		if(people[index].height==0)
			targerIndex=index
		end
	end
	for index in (0...people.length)
		if (people[index].gender == people[targerIndex].gender&& index!=targerIndex)
			tempRatio = (people[index].weight - people[targerIndex].weight).abs
			if(tempRatio<ratio)
				ratio=tempRatio
				ratioIndex=index
			end
		end
	end
	puts"Maximum-Atitikmuo:  #{index} asmuo, ugis:#{people[ratioIndex].height}"
end

people=[]
people<<Person.new(0,165,55)
people<<Person.new(1,201,95)
people<<Person.new(0,171,60)
people<<Person.new(1,194,102)
people<<Person.new(1, 0, 80)
people<<Person.new(1,189,90)
puts"ID : gender : height : weight---------------"
for index in (0...people.length)
	puts" #{index+1} : #{people[index].gender} : #{people[index].height} : #{people[index].weight}"
end
Euclidean(people)
Manhattan(people)
Maximum(people)
