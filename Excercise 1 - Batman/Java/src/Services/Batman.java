package Services;
public class Batman {
	public static String IAMBATMANize(String str) {
		int noOfVowels = 0;
		String batman = "";
		for (char chr : str.toCharArray()) {
			if ("aeiou".indexOf(chr) != -1) {
				noOfVowels++;				
			}
		}

		if ((double) noOfVowels / str.length() > 0.3) {
			boolean beginOfset = true;
			for (char chr : str.toCharArray()) {
				if ("aeiou".indexOf(chr) != -1) {
					if (beginOfset) {
						batman += "iambatman";
						beginOfset = false;
					}
				} else {
					batman += chr;
					beginOfset = true;
				}
			}
			return batman;
		}
		return str;
	}
	
	

}
