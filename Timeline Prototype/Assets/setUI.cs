using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setUI : MonoBehaviour {

    public Text title;
    public Text date;
    public Text description;
    public Image image;
    public Sprite edwidge;
    public Sprite myrtleDeath;

	// Use this for initialization
	void Start () {
        int billboardNumber = PlayerPrefs.GetInt("billboardNumber");

        if (billboardNumber == 0)
        {
            title.text = "Miss Myrtle E. Woldson Bequeaths Funds for Performing Arts Center at Gonzaga";
            date.text = "2014";
            description.text = "This article on the GU news service website describes Myrtle Woldson's quiet philanthropy in the Spokane community over the years, including her generous donation to GU for a new performance and arts education space. Culture and Spokane - this article outlines all that Myrtle has brought to the Spokane community over the years, leaving behind a legacy of love, learning, and arts appreciation with her generous bequest to fund a new performing arts center at GU.";
            Destroy(image);
        } else if (billboardNumber == 1) {
            title.text = "Explore the Theater";
            date.text = "";
            description.text = "This page on the Fox Theater website states that 30 min complimentary tours of the theater are available on the first Friday of every month. One can also schedule a private tour through the Fox Theater docent for a Historic Preservation fee of $3. At the bottom of the page, one can see the inside of the Martin Woldson Theater through an interactive resource powered by Google. The theater is mostly golden with green and blue accents, featuring elaborate geometric art painted on the ceiling, gold detailing, and large, elaborate light fixtures.Culture and Spokane - The Martin Woldson Theater at the Fox is a prime example of the love of arts, music, architecture, and history that Myrtle fostered in Spokane through her philanthropy.";
            Destroy(image);
        } else if (billboardNumber == 2) {
            title.text = "Edwidge Woldson";
            date.text = "1886-1966, 2005";
            description.text = "This text states that Edwidge Woldson (1886-1966) was born to the pioneer Milot family in Montana and had 12 siblings. She married railroad contractor Martin Woldson at 22 before they moved to Spokane, where Martin helped introduce the Great Northern Railroad. The couple had two children, Frances and Myrtle, eventually settling in a mansion on Sumner Avenue overlooking the city. Along with her daughter Myrtle, Edwidge oversaw the renovation of the home into a magnificent showplace with extensive gardens. To honor her mother, Myrtle later funded the restoration of the Moore-Turner Heritage Gardens in 2005. Culture and Spokane - This article's discussion of Edwidge's French roots contributes to the conversation about Myrtle's taste for French culture. Similarly, Edwidge's fondness for gardening was passed down to Myrtle, who brought aesthetic beauty to Spokane through the Moore - Heritage Gardens.Edwidge and Martin's move to Spokane was important as they added to the business-hub/melting pot culture that burgeoned in the city, which was a major railroad center. Martin thrived in this environment as a railroad contractor.";
            image.sprite = edwidge;
        } else if (billboardNumber == 3) {
            title.text = "Philanthropist Woldson dies at 104";
            date.text = "2014";
            description.text = "This newspaper article announces that Myrtle, a prominent Spokane philanthropist, passed in her home at age 104. She was responsible for donating $3M for the restoration of the Fox Theater in honor of her father's love for music, and for funding the restoration of the Moore-Turner Heritage Garden to honor her mother's love for gardening. In 2010, the Spokane Park Board voted to change the name of Pioneer Park to Edwidge Woldson Park to honor Myrtle's donation to the garden. Myrtle's personal representative and close friend Mark Danner said she was an accomplished businesswoman who \"died as she lived, with dignity and in privacy.\" The accompanying obituary includes a black and white portrait of the elderly Myrtle Woldson and states that Myrtle was survived by nephews and cousins, extended family Mark Danner, and close friend Mayor David Condon. The text mentions her donations to the Fox Theater and Moore-Turner Heritage Gardens as well as her embodiment of the \"Age of Elegance.\" Funeral and mass arrangements are detailed at the conclusion of the obituary. The mass was held at St. Aloysius church on Gonzaga's campus. Culture and Spokane - Myrtle shaped the Spokane landscape physically and artistically as she brought high-quality music to the city through the Martin Woldson Theater at the Fox and contributed to the restoration of the aesthetic Moore - Turner Heritage Gardens.";
            image.sprite = myrtleDeath;
        } else if (billboardNumber == 4) {
            title.text = "Eulogy for Miss Woldson-Thayne McCulloh";
            date.text = "2014";
            description.text = "Thayne McCulloh begins his eulogy for Myrtle by outlining the era in which she grew up, the \"Age of Elegance.\" He then described how she was part of an inner circle of successful industrialist families in Spokane, the regional epicenter of mining, timber, agriculture, and culture. McCulloh continues by going deeper into their 20 year friendship, throughout which they met up many times to discuss the future of the city and GU. He also remembers her well-read nature and musical talent as well as her recognition of the importance of art and music. McCulloh comments that she witnessed crucial points in history such as the Depression and WWII, which combined with her father's railroad contractor insights aided her understanding of what leads to city growth. Myrtle's family and her independent decisions as a businesswoman played a direct role in the growth of Spokane, which she held a deep love for along with her parents. McCulloh then highlights Myrtle's sense of humor, love of surprising people, devotion to Zag basketball, and her incrementally more and more generous donation to GU Athletics. Overall, McCulloh remembers Myrtle as a quietly generous woman who cared deeply about her relationships and left behind a legacy of learning and love. Culture and Spokane - This source conveys that Myrtle brought growth, art, music, and education to Spokane through her special insight as a well - traveled, well - read businesswoman who lived through major US events such as WWII and the Depression.Her donations to GU and Spokane left behind a legacy of learning, creative expression, and love.";
            Destroy(image);
        } else if (billboardNumber == 5) {
            title.text = "David Condon's Eulogy and notes from Myrtle";
            date.text = "2014";
            description.text = "David Condon's eulogy for Myrtle captures the lovely character of Myrtle Woldson with anecdotes and letters from their many years of friendship. Condon begins with a brief Woldson family history describing Martin's immigration from Norway, how he met Edwidge while working in a railroad in Montana, and the family's move from Ash to Adams to Sumner, where Myrtle spent the rest of her life improving the house and the surrounding Spokane community. Condon's family was her next door neighbor for 40 years, and Condon recalls the chocolates Myrtle sent him for his birthday each year and the letters she wrote him while he was in army training each day without fail. Condon says he never knew life without Myrtle. He proceeds to describe her as a businesswoman with an uncanny sense of value in real estate, common sense, and pioneer spirit; a philanthropist with knowledge of what will make a place more beautiful and a desire to continue her parents' legacy, and a true friend. An excerpt from a letter Myrtle wrote Condon captures her love for furniture, gardening, business, and socializing perfectly. Another short note remembers she and Condon's road trip to Montana. A final anecdote about a prank Myrtle played on Condon's mother conveys Myrtle's joyful spirit. A note at the bottom of the page describes Myrtle's love of children. Culture and Spokane - the family history at the beginning of the source shows how immigrants and pioneers like Martin and Edwidge shaped the West. Their determination was passed down to Myrtle, who was also dedicated to improving the city around her.";
            Destroy(image);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
