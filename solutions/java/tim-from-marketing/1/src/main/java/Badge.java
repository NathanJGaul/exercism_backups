class Badge {
    public String print(Integer id, String name, String department) {
        StringBuilder badgeBuilder = new StringBuilder("");
        
        if (id != null){
            badgeBuilder.append('[')
                .append(id)
                .append("] - ");
        }
        
            badgeBuilder.append(name);
        
        if (department != null) {
            badgeBuilder
                .append(" - ")
                .append(department.toUpperCase());
        } else {
            badgeBuilder
                .append(" - ")
                .append("OWNER");
        }
            
        return badgeBuilder.toString();
    }
}
