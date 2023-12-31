@certificate
@regression
Feature: Certificate Management
In order to manage certificates effectively
As a user of the system
I want to create, update, delete, purge, and retrieve certificates

    @read
    @defaultUser
    Scenario: Retrieve a List of Certificates
        Given I am a registered user
        When I retrieve the list of certificates
        Then I should see all the certificates

    @create
    @defaultUser
    Scenario: Create a New Certificate - Happy Path
        Given I am a registered user
        When I attempt to create a new certificate
        Then the certificate should be successfully created

    @create
    @defaultUser
    Scenario: Create a New Certificate - Should Require Minimum Fields
        Given I am a registered user
        When I attempt to create a new certificate with missing minimum fields
        Then the creation should be denied due to validation error

    @create
    @defaultUser
    Scenario: Create a New Certificate - Should Require Unique Title
        Given I am a registered user
        And a certificate with a given title already exists
        When I attempt to create a new certificate with the same title
        Then the creation should be denied due to validation error

    @create
    @anonymousUser
    Scenario: Create a New Certificate - Should Deny Anonymous User
        Given I am anonymous user
        When I attempt to create a new certificate
        Then the creation should be denied due to unauthorized access error

    @update
    @defaultUser
    Scenario: Update an Existing Certificate - Happy Path
        Given I am a registered user
        And I have an existing certificate
        When I attempt to update a certificate
        Then the certificate should be successfully updated

    @update
    @defaultUser
    Scenario: Update Certificate - Should Require Valid Certificate Id
        Given I am a registered user
        And I have an invalid certificate id
        When I attempt to update a certificate
        Then the update should be denied due to invalid certificate id

    @update
    @defaultUser
    Scenario: Update Certificate - Should Require Unique Title
        Given I am a registered user
        And another certificate with a new title exists
        When I update the certificate with the new title
        Then the update should be denied due to non-unique title

    @update
    @anonymousUser
    Scenario: Update Certificate - Should Deny Anonymous User
        Given I am anonymous user
        And I have an existing certificate
        When I attempt to update a certificate
        Then the update should be denied due to unauthorized access error

    @delete
    @defaultUser
    Scenario: Delete Certificate - Happy Path
        Given I am a registered user
        And I have an existing certificate
        When I attempt to delete a certificate
        Then the certificate should be successfully deleted

    @delete
    @defaultUser
    Scenario: Delete Certificate - Should Require Valid Certificate Id
        Given I am a registered user
        And I have an invalid certificate id
        When I attempt to delete a certificate
        Then the deletion should be denied due to invalid certificate id

    @delete
    Scenario: Delete Certificate - Should Deny Anonymous User
        Given I am anonymous user
        And I have an existing certificate
        When I attempt to delete a certificate
        Then the deletion should be denied due to unauthorized access error

    @purge
    @adminUser
    Scenario: Purge All Certificates
        Given I am an administrative user
        When I purge all certificates
        Then all certificates should be successfully purged

    @purge
    Scenario: Purge Certificates - Should Deny Anonymous User
        Given I am anonymous user
        When I attempt to purge all certificates as an anonymous user
        Then I should be denied access to purge

    @purge
    @defaultUser
    Scenario: Purge Certificates - Should Deny Non-Administrator
        Given I am a registered user
        When I attempt to purge all certificates as a non-administrator
        Then I should be denied access to purge due to lack of administrative privileges