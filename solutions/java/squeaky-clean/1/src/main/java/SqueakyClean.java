class SqueakyClean {
    static String clean(String identifier) {
        var sb = new StringBuilder();
        var isKabab = false;
        for (var ch: identifier.toCharArray()) {
            if (Character.isWhitespace(ch)){
                sb.append('_');
            } else if (ch == '-') {
                isKabab = true;  
            } else if (isKabab && Character.isLetter(ch)) {
                sb.append(Character.toUpperCase(ch));
                isKabab = false;
            } else if (Character.isDigit(ch)) {
                if (ch == '4') {
                    sb.append('a');
                } else if (ch == '3') {
                    sb.append('e');
                } else if (ch == '0') {
                    sb.append('o');
                } else if (ch == '1') {
                    sb.append('l');
                } else if (ch == '7') {
                    sb.append('t');
                } else {
                    sb.append(ch);
                }
            } else if (Character.isLetter(ch)) {
                sb.append(ch);
            }
        }
        return sb.toString();
    }
}
