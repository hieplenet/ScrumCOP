package Services

import "strings"

func IAMBATMAN(str string) string{
	 var noOfVowels int
	 var batman string
	 for _,item := range str{
	 	if(strings.Contains("aeiou", string(item))){
	 		noOfVowels++;
	 	} 
	 }
	
	 if float32(noOfVowels)/float32(len(str)) > 0.3 {
	 		var beginOfset bool = true
	 		 for _,item := range str{
			 	if(strings.ContainsRune("aeiou", item)){
					 if beginOfset {
					 	batman += "iambatman"
					 	beginOfset = false
					 	}
					 } else {
					 	batman += string(item)
					 	beginOfset=true
				 	} 
			 }
	 		return batman;
	 }
	return str
}