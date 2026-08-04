public class LogLevels {
    
    public static String message(String logLine) {
        // sutract level and template characters
        String[] split = logLine.split(":");

        // strip message of left and right white spaces
        String message = split[1].trim();

        // return message
        return message;
    }

    public static String logLevel(String logLine) {
        String[] split = logLine.split(":");

        String logLevel = split[0].replace("[", "").replace("]", "");

        return logLevel.toLowerCase();
    }

    public static String reformat(String logLine) {
        return "%s (%s)".formatted(message(logLine), logLevel(logLine));
    }
}
