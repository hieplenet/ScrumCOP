package Test;

import static org.junit.Assert.*;

import org.junit.Test;

import Services.Batman;

public class BatmanShould {
	
	@Test
	public void Convert_Vowels_If_Input_String_Contains_More_Than_30_Percent_Vowel() {		
		assertEquals("iambatman", Batman.IAMBATMANize("aa"));
		assertEquals("biambatman", Batman.IAMBATMANize("ba"));
	}
	
	@Test
public void Not_Convert_Vowels_If_Input_String_Contains_Less_Than_30_Percent_Vowel() {
		assertEquals("abbb", Batman.IAMBATMANize("abbb"));
	}

}
