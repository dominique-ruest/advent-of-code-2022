using BenchmarkDotNet.Attributes;

namespace AdventOfCode2022.December6
{

    //BENCHMARK
    //|                      Method |        Mean |     Error |    StdDev |     Gen0 |   Gen1 | Allocated |
    //|---------------------------- |------------:|----------:|----------:|---------:|-------:|----------:|
    //|    RunNaiveAppoachBenchmark | 1,730.96 us | 22.725 us | 21.257 us | 779.2969 | 1.9531 | 3587.9 KB |
    //| RunClevererAppoachBenchmark |    64.98 us |  0.673 us |  0.630 us |   0.6104 |      - |   3.06 KB |

    [MemoryDiagnoser]
    public class Day6Program
    {
        private const string input = "bhzhtzzsczszsjjjzddfzdfzfjfzfbbnntnzznwzzvfvrrqmrmmdzzfqfhqhsqqpwpgwpppbtbnnstthmhrrsmmvsmmhjmjfmfsfjfnfnjjvcjjszjszjsszbznzbnzndzzmlldsdgdcddmqmfqqlcllbvllztzctzczdzttlmtlthtmhtmhmmszsllvzvdzzzsqzqbqccvfvcffzsfslfsllcglclwlvwvzzdsslggtzzgzdzmzddjljvvztttsgscsstztjztjztzvzwwthtftppnmpmmcpmmjlmjjjsfjsjppgcgwcggzffzwzbbmbrbprpqqpccfncfnffvcffsqqtzqzqwzwvzwwwbjbfbcbfblltnlnhhcthtvvzzfcfgfddlggbbshsggplglqqbrbggsvvzdvvlfvlvpvhhmggbrrnppjfjhffttfpffbdfbfvfqvvtcvvbvnnhbhhglgjgzzghhwrrtntrtwwfdfdmmcmtctftpptllzqllzflfrrgqgvgdvdfdbddprrrgccqvqnnmtmvmffpzzqggfbfnfwwqdqldqqlnqnttnbttrffnmmzwzjjtrjtrtmmqsmqmffqmfqfhhbthbhdhvdhvdvmvdmdhdshsqslldzztvvmzzdcccmbbhfhshrrrpsrrqqmdmmgdmmwdmdjdqqmcmttpgtgwgpwpprbrprhrsrllhsllprlplhppfzpffbhbccwdwbbrpbpvpqqmsspjssmbbmfmrmnrnwwgbwwbpwpjwwhqqgcqcvqccgffzpfftcffqlqjjznnlflhhlcczhzvhzhmzhmhfhnnqznntstwtggqjgjhggsvslltjlttfjjgffjzjwzzqzrrhlhzhbhphmhlmlzmzsmzmccvllgrrpbrbfbjfjttqjttdrdhhggqgddppqgpqgpgtptjptpllwccmwcmcpmcppdrrtstqqczqzvvlsltlddnvdvggcqqblqqsjqjttzhtzzszllqsqfqddqdbqddwqddfzzlczcscfsfpfdpdrpddsggcqchcfcpcssstwstwtggghvhqhzzqssjddwjwbjjsnjnfnwwglwwfnfhnnscsggzgjzzhzmmqfqsqwqrwqqqdtdcttzvvnbngbbcdbdggddnmddgzghhzgghwwbjbttlwlcctlccwwdhhrqrvrjjlglssgttpllwclwwtptwptwtvthtbhbzhbzhhrsrwwwnrwrfwfnwnhhnqqdjqjpqqwdwttzhttcdttvztzltzlzmzddrsdsfdsfftdfffmwffrjrffqrfqfsfqqqgqjggwzzrnnqfnqffdbfbtbbrpbrpbptpwttjmjjzrrhhqppdzdtdjttqwwtddjdzzmgzzhwwwdsdgssprsrgsgbbphhdpdwppnfppdqqwzzpbzzqwqpqsqhqdhqqtwwjnnmvmwvmmwwgjgzjjvcjcvcjcnjcncmmphmmvmwmwpwbbtbffhnhshgssgvgvrrbwbtbddqmqfqvvfqvqdvvdbvdbdcdfdlflmffrwwgmmttrztrrfrqrpqrrzjrjpjdpjprrnhhbhcbbcwwqlwwcssbddfrfjrfjfrjfjvvdmdtdzzlvzlzhzmhmhphchnnfqnffvccfpfbfpfqpprrmttzrzzjzmjmzjmmfvmmrzrqqdllgjlglcchssgllsbllrbrlrjlrrhhfwwsqwsstpssznzcznzqzssvtvtrrqwqvvtssgfsfhssljjnwjnjddjdggclcrrfsfhsstgtdtctfttvvsbvvbtbttcgcssjlslhlpljpppwzwnwdnngmgjjbzznwwdllrrfppshhvdhhldhdbbdbjbdjjrnjjzhzfhhsqqbqgmsbvnjsptlrsszlqfmgprvscphmqztbgtlrqvcgdzcptcqjncrdtfqnghnbmwwmcjgtjlbvqqzslgbbntrdfnvfjvfgcgngndjcspgwmpnsrqzzvzljbzlzzrwflrqqqmhsvqwbmdftnhwwzgqrlhddbbtwvbphljmstcjzvpjqwcnhlvpqvqdgvntgqzqwrlwbwvngwtqgrhznlzcvbwqmwncccjctrdzrmzjsvrmcfpjjcczhbvdfwhqvczggfmrspvprvvthvtqnsphpcsdmbrtbdqljvssdrhwjsrrlzprstpgqcbpmnpdgzgjttwcfrgjnsghmszlclgvmlsjrqfvflbnhwwphtvrnrbhdvdglcvgpzfsjpwwhtlvvdzthsrldfzhnlrblzsjjnwclqsqzgdbflhvpwcrtfbfbjcjttbjpvfgvfcswnqqwshbmqlscdzzwshfqwsvwnwzltbnrmzzhzvtwpzqcgwshpvzgtcmwrtrwctnpzbznnwqphnrgwljtrcwlqmvlndwrdrctztnmswslqmbjcmtlrmcpjvzccqszrnflqnqzttbhqlrhbmqdpscqvfgtdbnwjdcljwcbgbgjfzgrgpwqzqgbnrtpntfthhdbqmswvhnmwmszpghgjjzrbnbbfjblpstdfslmmmqfdcrhblqjqfphnldrvvfpnfrcvprjnqbzbspfpjtgqhnjbhnrwzcjvdbshhqpgrmzqpmjfmqwqvvdbddbsldwzzsrhnhsjjnvljrbwcnjrnjpmrrvfthftgptgtlpbgqffthflgftwcrqcqwqwrmrcmfrcqgmrnqjbscdcgrqlhjzthvzdgjbvpswflqcgsnlmgmvcsttsgmnqdtvwdvrndvfdcvrcwmqlmlhtrvthsndsrmnsfmdmfnpfmfhzjqmtcjzcrnsjdztztvgdtlrmbdmmstbfgpmmzthcslpvgrpgfljfgqlqhldfwvvvdvbzjtdtppbtrnqwsqztjrsjhtfrgmvsdngvsdzjgpwrldqpzdpvhljzpjvttwltdwcrhcbrgrvdrmpwvdwjchqsjfprbgtjtzggvgrgmlvvwqrjfprbbgjjqrtdfnrdffwbswbvqtqtfsrhsgrjhftqldhmcnmsnfflmdrzqdjmbqqgqsttdmtrrvfsjnccnhcpcvqtrzdjzrpwswmjvvgsgwvnmdgqwlctrlhqnsmczbwsjhmtgvdcgsndzlstcwchcztqqbtdwfvlljdvdlzljslgnzpmqvzfcvqhdzvgchffqgfwrnmwqzwgbzblpmvddlvnhglrhdnwzqwztzgjczjpwcjwmpnrnrhncfjfggrbphrjztwtfqmfjlwfhnqfftfghbnvtwgtmdzzrdrtmfrwhrrbhzmcllsgqzwzzqtgdggvzptvtdcpzmtmsfcfbjtzlbdrwhdbtdhhrgggmddnzsvjwgcdcqfppqwphfvlhmgqsznlhmgpnjvcvrwwppnphchgsrhjwjcpjggsrcwrvnllfgrmjltfzwhmbqwpwwzmrtlqcprrqztcgnghcbvzrbfptjmhtdcfhhffdbrswqpnpppnpqwtflrrmqgjzctmmvvvwzllbsfdvpqjtmvpjcpmjztscsgbdznfgcmtjzdqzwqrsvstnnvddcstzqjtnbsnlptpmbmfqmhppgnjrffqrtchgptbmwlwbwbcqqfngpbwtwdmlmdstmqwcwjtbwbbbhghgptmvhfmvqfvpwqzwnbjdhpwlgjgvprdjbnlzhnllssbpvzfzspwsscfpqtpdvtzvqncfrfrgddsdglqvpblmpcczlqfdmwzmgvrljhqtcglcvfhbdwhbttqqrjbqwhsrhrbjwmtqwqddvdggdwfsmnpbpvvgsqnvvrqntwmbzdnqpmmqtbnlsbmslpfmqjtgvbddhwvlvjtlrhqdpfnjwtbhwjwdrpgctbbrdqvbbnvgqwngrhqfvwzmlqtmhfqphnmczlbdpnbmpvwrsjbcnjnvcfgnsvlhpzdgdzgvfbgwdcrswznrggnghzssdwqvvlwftqhbnwdvghhvjlqqmcnqmvbwhrrnsswlwmwbsmpcpdzzgmcmqnzpvjpzqbwcsgdhqtqhcpbtqftvscmntsbdcbrndvlfhprpblzbjcpqhfljtvnvtgvrcgqbsgl";

        public void Run()
        {

            Console.WriteLine("Characters to find marker of length 4: " + (FindUniqueMarkerEndIndexClevererApproach(input, 4) + 1));
            Console.WriteLine("Characters to find marker of length 14: " + (FindUniqueMarkerEndIndexClevererApproach(input, 14) + 1));
        }


        [Benchmark]
        public void RunNaiveAppoachBenchmark()
        {
            _ = FindUniqueMarkerEndIndexNaiveApproach(input, 4);
            _ = FindUniqueMarkerEndIndexNaiveApproach(input, 14);
        }

        [Benchmark]
        public void RunClevererAppoachBenchmark()
        {

            _ = FindUniqueMarkerEndIndexClevererApproach(input, 4);
            _ = FindUniqueMarkerEndIndexClevererApproach(input, 14);
        }


        public static int? FindUniqueMarkerEndIndexNaiveApproach(string input, int markerLength)
        {
            for (var i = markerLength - 1; i < input.Length; i++)
            {
                if (input.Substring(i - markerLength + 1, markerLength).GroupBy(c => c).Count() == markerLength)
                {
                    return i;
                }
            }

            return null;
        }

        public static int? FindUniqueMarkerEndIndexClevererApproach(string input, int markerLength)
        {
            var latestCharacterIndexes = new Dictionary<char, int>();
            var markerStartIndex = 0;

            for (var currentIndex = 0; currentIndex < input.Length; currentIndex++)
            {
                var currentChar = input[currentIndex];

                var lastIndexCharacterSeenAt = latestCharacterIndexes.TryAdd(currentChar, currentIndex)
                    ? currentIndex : latestCharacterIndexes[currentChar];

                latestCharacterIndexes[currentChar] = currentIndex;

                if (lastIndexCharacterSeenAt != currentIndex && lastIndexCharacterSeenAt >= markerStartIndex)
                {
                    markerStartIndex = lastIndexCharacterSeenAt + 1;
                }
                else if (currentIndex - markerStartIndex + 1 == markerLength)
                {
                    return currentIndex;
                }
            }

            return null;
        }
    }
}
