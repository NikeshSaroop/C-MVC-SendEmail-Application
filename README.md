# C-MVC-SendEmail-Application
Send an email using smtp


changes to make in web.config

add the following:

<mailSettings>
      <smtp from="enter sender email address here">
        <network host="smtp.gmail.com" port="587" userName="Enter Sender Email Address here!!!" password="Enter Sender Email Password Here!!!" enableSsl="true" />
      </smtp>
    </mailSettings>
    
    
add this to add settings in web.config

<add key="EmailToAddress" value="Enter Reciever Email address here!!!" />
