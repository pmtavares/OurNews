import React from 'react'
import { Grid,Card, Placeholder } from 'semantic-ui-react'

const ArticleByCategory = () => {
    return (
        <Grid>
           <Grid.Row columns={2}>
               <Grid.Column>
                    <Grid.Column>
                        <Card.Group itemsPerRow={3}>
                            <Card>
                                <Card.Content>
                                    <Placeholder>
                                    <Placeholder.Image square />
                                    </Placeholder>
                                </Card.Content>
                            </Card>
                        </Card.Group>
                    </Grid.Column>
                    <Grid.Column>
                        <Placeholder>
                            <Placeholder.Line length='full' />
                            <Placeholder.Line length='very long' />
                            <Placeholder.Line length='long' />
                            <Placeholder.Line length='medium' />
                            <Placeholder.Line length='short' />
                            <Placeholder.Line length='very short' />
                        </Placeholder>
                    </Grid.Column>

               </Grid.Column>
               <Grid.Column>
                    <Grid.Column>
                        <Placeholder>
                            <Placeholder.Line length='full' />
                            <Placeholder.Line length='very long' />
                            <Placeholder.Line length='long' />
 
                        </Placeholder>
                    </Grid.Column>
                    <Grid.Column>
                        <Placeholder>
                            <Placeholder.Line length='full' />
                            <Placeholder.Line length='very long' />
                            <Placeholder.Line length='long' />

                        </Placeholder>
                    </Grid.Column>
                    <Grid.Column>
                        <Placeholder>
                            <Placeholder.Line length='full' />
                            <Placeholder.Line length='very long' />
                            <Placeholder.Line length='long' />
                        </Placeholder>
                    </Grid.Column>
               </Grid.Column>
           </Grid.Row> 
        </Grid>
    )
}

export default ArticleByCategory
