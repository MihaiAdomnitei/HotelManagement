module ubb.map.practic2023v1 {
    requires javafx.controls;
    requires javafx.fxml;
    requires java.sql;


    opens ubb.map.practic2023v1 to javafx.fxml;
    exports ubb.map.practic2023v1;
}