bool CanConstruct(string ransomNote, string magazine) {
    char[] ransomNote_ = ransomNote.ToCharArray();
    char[] magazine_ = magazine.ToCharArray();
    int ransomNote_Length = ransomNote_.Length;
    int magazine_Length = magazine_.Length;
    bool canConstruct = false;
    int ransomNote_CheckPosition = 0;
    if (magazine_Length < ransomNote_Length) return false;
    for (int i = 0; i < magazine_Length; i++) {
        if (ransomNote_Length < (ransomNote_CheckPosition + 1)) break;
        char _ransomNote = ransomNote_[ransomNote_CheckPosition];
        char _magazine = magazine_[i];
        if (_magazine == _ransomNote) {
            canConstruct = true;
            ransomNote_CheckPosition++;
        } else {
            if (canConstruct) i--;
            canConstruct = false;
            ransomNote_CheckPosition = 0;
        };
    };
    return canConstruct;
};
bool a = CanConstruct(
    ransomNote: "fffbfg",
    magazine: "effjfggbffjdgbjjhhdegh"
    );
Console.WriteLine(a);