class Solution:
    def repeatedSubstringPattern(self, s: str) -> bool:
        for i in range(1, len(s)):
            if len(s) % i == 0:
                broke = False
                for j in range(i, len(s), i):
                    if s[0:i] != s[j:j+i]:
                        broke = True
                        break
                
                if not broke:
                    return True

        return False
